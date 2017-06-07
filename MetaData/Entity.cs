using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataServicesViewer
{
    public class EDMElement
    {
        public string Name { get; set; }
        public string NameType { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Type: {1}", Name, NameType);
        }
    }
    public class EntityContainer : EDMElement
    {        
        public EntityContainer()
        {
            this.EntitySets = new Dictionary<string,EntitySet>();
            this.AssociationSet = new Dictionary<string, Association>();
        }

        public Dictionary<string,EntitySet> EntitySets { get; set; }
        public Dictionary<string, Association> AssociationSet { get; set; }  
    }
    public class EntitySet : EDMElement
    {
        public Entity Entity;
        
        public EntitySet()
        {
            this.Entities = new Dictionary<string, Entity>();
            this.Entity   = new Entity();
        }
        public EntitySet(string name , string entityType) : this()
        {
            this.Name       = name;
            NameType = entityType;//.Split('.').Last();
            Entity.NameType = NameType;
            Entity.Name     = NameType;
        }

        public Dictionary<string,Entity> Entities { get; set; }
    }
    public class Entity : EDMElement
    {
        public Entity()
        {
            Keys = new Dictionary<string, string>();
            Properties = new Dictionary<string, Property>();
            NavigationProperties = new Dictionary<string, Entity>();
        }

        public Dictionary<string, string> Keys { get; set; }
        public Dictionary<string, Property> Properties { get; set; }
        public Dictionary<string, Entity> NavigationProperties { get; set; }
    }
    public class EntitySource : EDMElement
    {
        public DSType EntityType { get; set; }
        public bool IsNull
        {
            get { return string.IsNullOrEmpty(NameType); }
        }
    }
    public class Property : EDMElement
    {
        public bool Nullable    { get; set; }
        public int MaxLength    { get; set; }
        public bool Unicode     { get; set; }
        public bool FixedLength { get; set; }
    }
    public class Association : EDMElement
    {
        public List<EndRole> EndRoles { get; set; }

        public Association()
        {
            EndRoles = new List<EndRole>();
        }
    }
    public class EndRole
    {
        public string Role { get; set; }
        public string Type { get; set; }
        public string EntitySet { get; set; }
        public string Multiplicity { get; set; }
    }
}
