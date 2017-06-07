using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataServicesViewer
{
    public enum IconsEnum
    {
        Property,
        Nav,
        OpenFolder,
        CloseFolser,
        Keys,
        Key
    }
    public static class EntitiesTree
    {
        public static void BuildTree(this TreeView source, MetaData metaData )
        {
            source.BeginUpdate();
            TreeNode root = source.Nodes.Add( metaData.model.Name );

            TreeNode entitySet = root.Nodes.Add("EntitySet");
            entitySet.ImageIndex = (int)IconsEnum.CloseFolser;

            foreach (var item in metaData.model.EntitySets.Values)
            {
                entitySet.Nodes.Add(item.NameType).BuildEntity(item.Entity);
            }
            source.EndUpdate();
        }

        public static void BuildEntity(this TreeNode source, Entity e)
        {
            TreeNode Keys = source.Nodes.Add("Keys");
            Keys.ImageIndex = (int)IconsEnum.Keys;

            foreach (var k in e.Keys)
            {
                Keys.Nodes.Add(k.Key).ImageIndex = (int)IconsEnum.Key;
            }

            TreeNode prop = source.Nodes.Add("Properties");
            prop.ImageIndex = (int)IconsEnum.CloseFolser;

            foreach (var p in e.Properties)
            {
                prop.Nodes.Add(p.Key).ImageIndex = (int)IconsEnum.Property;
            }

            TreeNode nav = source.Nodes.Add("Navigation Properties");
            nav.ImageIndex = (int)IconsEnum.CloseFolser;

            foreach (var n in e.NavigationProperties)
            {
                nav.Nodes.Add(n.Key).ImageIndex = (int)IconsEnum.Nav;
            }
        }
    }
}
