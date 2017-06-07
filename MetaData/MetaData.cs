using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Linq;
using System.IO;

namespace DataServicesViewer
{
    public class MetaData
    {
        // Old .NET 3.0
        // const string EDMNS = "{http://schemas.microsoft.com/ado/2006/04/edm}";

        // .NET 3.5 & 4.0
        const string EDMNS = "{http://schemas.microsoft.com/ado/2008/09/edm}";

        Uri ServiceUri;
        WebClient proxy;
        XDocument XmlDoc;

        public event EventHandler ReadCompleted;
        public EntityContainer model;

        public MetaData( string ServiceUrl )
        {
            this.ServiceUri = new Uri( ServiceUrl );
            proxy           = new WebClient();
            XmlDoc          = new XDocument();
            model           = new EntityContainer();

            proxy.OpenReadAsync(ServiceUri);
            proxy.OpenReadCompleted += new OpenReadCompletedEventHandler(proxy_OpenReadCompleted);
        }

        void proxy_OpenReadCompleted(object sender, OpenReadCompletedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(e.Result))
            {
                XmlDoc = XDocument.Parse( sr.ReadToEnd() );
            }
            BuildModel();
        }


        void BuildModel()
        {
            if (XmlDoc.Root != null)
            {
                var entityContainer = XmlDoc.Root.Descendants( EDMNS + "EntityContainer");
                if (entityContainer != null)
                {
                    model.Name = entityContainer
                                    .First()
                                    .Attribute("Name").Value;
                }
            }

            BuildEntitySets();
        }
        void BuildEntitySets()
        {
            foreach (var item in XmlDoc.Root.Descendants(EDMNS + "EntitySet") )
            {
                model.EntitySets.Add(
                    item.Attribute("Name").Value,
                    new EntitySet( 
                        item.Attribute("Name").Value,
                        item.Attribute("EntityType").Value));
            }
            BuildAssociationSet();
            BuildEntities();
        }

        void BuildAssociationSet()
        {
            foreach ( var item in XmlDoc.Root.Descendants( EDMNS + "AssociationSet" ) )
            {
                string key = item.Attribute( "Name" ).Value;
                model.AssociationSet.Add( key , new Association() );

                foreach ( var er in item.Elements() )
                {
                    model.AssociationSet[key].EndRoles.Add(
                        new EndRole
                        {
                            Role      = er.Attribute( "Role" ).Value,
                            EntitySet = er.Attribute( "EntitySet" ).Value
                        }
                    );
                }
            }
        }
        void BuildEntities()
        {
            Dictionary<string, XElement> EntityTypes = new Dictionary<string, XElement>();
            foreach (var et in XmlDoc.Root.Descendants(EDMNS + "EntityType"))
            {
                EntityTypes.Add(et.Attribute("Name").Value, et);
            }

            foreach (var item in model.EntitySets.Values)
            {
                XElement xe = EntityTypes[item.NameType];

                BuildEntityKeys(item.Entity, xe);
                BuildEntityProperties(item.Entity, xe);            
                BuildEntityNavigationProperties(item.Entity,xe);
            }

            if (ReadCompleted != null) ReadCompleted(this, EventArgs.Empty);
        }
        void BuildEntityProperties(Entity e, XElement xe)
        {            
            foreach( var prop in xe.Elements(EDMNS + "Property") )
            {
                Property p = new Property();

                p.Name        = prop.Attribute("Name").Value;
                p.NameType    = prop.Attribute("Type").Value;
                p.Nullable    = bool.Parse(prop.Attribute("Nullable").Value);
                //p.MaxLength   = int.Parse(prop.Attribute("MaxLength").Value);
                //p.FixedLength = bool.Parse(prop.Attribute("FixedLength").Value);
                //p.Unicode     = bool.Parse(prop.Attribute("Unicode").Value);


                e.Properties.Add( p.Name , p );
            }
        }
        void BuildEntityKeys(Entity e, XElement xe)
        {
            XElement keys = xe.Element(EDMNS + "Key");
            
            if (keys == null) return;

            foreach (var key in keys.Elements(EDMNS + "PropertyRef"))
            {
                e.Keys.Add(key.Attribute("Name").Value, key.Attribute("Name").Value);
            }            
        }
        void BuildEntityNavigationProperties(Entity e, XElement xe)
        {         
            string FromRole;
            string ToRole;
            string Relationship;
            string KeyNav;

            foreach( var navi in xe.Elements(EDMNS + "NavigationProperty") )
            {
                KeyNav       = navi.Attribute( "Name" ).Value;
                FromRole     = navi.Attribute("FromRole").Value;
                ToRole       = navi.Attribute("ToRole").Value;
                Relationship = navi.Attribute( "Relationship" ).Value.Split('.').Last();

                Association ass = model.AssociationSet[Relationship];

                string es = (from x in ass.EndRoles
                               where x.Role == ToRole
                               select x.EntitySet).First();

                e.NavigationProperties.Add( KeyNav, model.EntitySets[es].Entity );


                //if ( model.EntitySets.ContainsKey( ToRole ) )
                //    e.NavigationProperties.Add( 
                //        navi.Attribute("Name").Value , model.EntitySets[ToRole].Entity );
                //else
                //{
                //    e.NavigationProperties.Add(
                //        navi.Attribute("Name").Value, null );
                //}
            }
        }        
    }
}
