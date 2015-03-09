using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace VideoPlayer.UITypeEditors
{
    public class TimeSpanEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle( ITypeDescriptorContext context )
        {
            return UITypeEditorEditStyle.DropDown;
        }

        public override object EditValue( ITypeDescriptorContext context, IServiceProvider provider, object value )
        {
            var service = ( IWindowsFormsEditorService ) provider.GetService( typeof ( IWindowsFormsEditorService ) );

            if ( service == null )
                return value;
            var dateTimePicker = new DateTimePicker { Value = DateTime.Today.Add( ( TimeSpan ) value ), Format = DateTimePickerFormat.Time, ShowUpDown = true };

            service.DropDownControl( dateTimePicker );
            value = dateTimePicker.Value.TimeOfDay.ToString();

            return value;
        }
    }
}