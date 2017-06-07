using ODataViewer.Properties;
using System.Windows.Media.Imaging;

namespace DataServicesViewer
{
    public class IntellisenseItem
    {
        DSType m_Type;

        public IntellisenseItem()
        {
        }
        public IntellisenseItem(string text, DSType type) : this()
        {
            this.Text = text;
            this.Type = type;

            SetPicture();
        }
        public IntellisenseItem(string text, DSType type, string tooltip ) 
            : this(text , type )
        {
            this.ToolTip = tooltip;
        }
        
        public string Text { get; set; }
        public string ToolTip { get; set; }
        public DSType Type 
        {
            get { return m_Type; }
            set { m_Type = value; SetPicture(); }
        }
        public EDMElement Element { get; set; }
        public BitmapSource Picture { get; set; }

        private void SetPicture()
        {
            switch (this.Type)
            {
                case DSType.End:
                    this.Picture = Resources.End.ToBitmapSource();
                    break;

                case DSType.EntitySet:
                    this.Picture = Resources.EntitySet.ToBitmapSource();
                    break;

                case DSType.Entity:
                    this.Picture = Resources.Entity.ToBitmapSource();
                    break;

                case DSType.Operation:
                    this.Picture = Resources.Operation.ToBitmapSource();
                    break;

                case DSType.Key:
                    this.Picture = Resources.Key.ToBitmapSource();
                    break;

                case DSType.Property:
                    this.Picture = Resources.Property.ToBitmapSource();
                    break;

                case DSType.NavigationProperty:
                    this.Picture = Resources.NavigationProperty.ToBitmapSource();
                    break;

                case DSType.Function:
                    this.Picture = Resources.Function.ToBitmapSource();
                    break;

                case DSType.Expression:
                    this.Picture = Resources.Function.ToBitmapSource();
                    break;

                default:
                    break;
            }
        }        
    }
}
