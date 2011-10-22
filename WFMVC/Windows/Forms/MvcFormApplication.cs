using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace WFMVC.Windows.Forms
{

    /// <summary>
    /// Prove extensões pra formulários no padrão MVC, permitindo a conversão de formulário em entidade e virse-versa.
    /// </summary>
    public static class MvcFormApplicationExtensions
    {
        /// <summary>
        /// Retorna um modelo genérico a partir de um objeto Form, equiparando os campos do 
        /// formulário às propriedades do objeto.
        /// </summary>
        /// <typeparam name="T">Tipo da entidade</typeparam>
        /// <param name="form">Formulário a ser convertido</param>
        /// <returns></returns>
        public static T Model<T>(this Form form)
        {
            FieldInfo[] formFields = form
                .GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            T obj = Activator.CreateInstance<T>();

            PropertyInfo[] objProperties = obj
                .GetType()
                .GetProperties();

            foreach (FieldInfo f in formFields)
            {
                if (!objProperties.Select(p => p.Name).Contains(f.Name))
                    continue;

                Type t = obj.GetType().GetProperty(f.Name).PropertyType;
                switch (f.FieldType.Name)
                {
                    case "MaskedTextBox":
                        MaskedTextBox maskedTextBox = (MaskedTextBox)f.GetValue(form);
                        if (t == typeof(decimal) || t == typeof(Decimal))
                        {
                            decimal number = 0;
                            decimal.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(double) || t == typeof(Double))
                        {
                            double number = 0;
                            double.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(string) || t == typeof(String))
                        {
                            obj.GetType().GetProperty(f.Name).SetValue(obj, maskedTextBox.Text, null);
                        }
                        if (t == typeof(int) || t == typeof(Int32))
                        {
                            int number = 0;
                            int.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(long) || t == typeof(Int64))
                        {
                            long number = 0;
                            long.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        break;

                    case "TextBox":
                        TextBox textBox = (TextBox)f.GetValue(form);
                        if (t == typeof(decimal) || t == typeof(Decimal))
                        {
                            decimal number = 0;
                            decimal.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(double) || t == typeof(Double))
                        {
                            double number = 0;
                            double.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(string) || t == typeof(String))
                        {
                            obj.GetType().GetProperty(f.Name).SetValue(obj, textBox.Text, null);
                        }
                        if (t == typeof(int) || t == typeof(Int32))
                        {
                            int number = 0;
                            int.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(long) || t == typeof(Int64))
                        {
                            long number = 0;
                            long.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        break;
                    case "DateTimePicker":
                        DateTimePicker dateTimePicker = (DateTimePicker)f.GetValue(form);
                        obj.GetType().GetProperty(f.Name).SetValue(obj, dateTimePicker.Value, null);
                        break;
                    case "CheckBox":
                        CheckBox checkBox = (CheckBox)f.GetValue(form);
                        obj.GetType().GetProperty(f.Name).SetValue(obj, checkBox.Checked, null);
                        break;
                    case "ComboBox":
                        ComboBox comboBox = (ComboBox)f.GetValue(form);
                        obj.GetType().GetProperty(f.Name).SetValue(obj, comboBox.SelectedItem, null);
                        break;
                    default:
                        break;
                }
            }

            return obj;
        }

        /// <summary>
        /// Retorna um modelo a partir de um objeto Form, equiparando os campos do 
        /// formulário às propriedades do objeto
        /// </summary>
        /// <param name="form">Formulário a ser convertido</param>
        /// <returns></returns>
        public static object Model(this Form form)
        {
            object[] attributes = form.GetType().GetCustomAttributes(typeof(ViewAttribute), false);
            if (attributes.Count() == 0)
                throw new Exception("Verifique se o formulário contém anotação com o nome do modelo.");

            ViewAttribute va = (ViewAttribute)attributes[0];

            object obj = Activator.CreateInstance(va.Type);

            FieldInfo[] formFields = form
                .GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
                        
            PropertyInfo[] objProperties = obj
                .GetType()
                .GetProperties();

            foreach (FieldInfo f in formFields)
            {
                if (!objProperties.Select(p => p.Name).Contains(f.Name))
                    continue;

                Type t = obj.GetType().GetProperty(f.Name).PropertyType;
                switch (f.FieldType.Name)
                {
                    case "MaskedTextBox":
                        MaskedTextBox maskedTextBox = (MaskedTextBox)f.GetValue(form);
                        if (t == typeof(decimal) || t == typeof(Decimal))
                        {
                            decimal number = 0;
                            decimal.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(double) || t == typeof(Double))
                        {
                            double number = 0;
                            double.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(string) || t == typeof(String))
                        {
                            obj.GetType().GetProperty(f.Name).SetValue(obj, maskedTextBox.Text, null);
                        }
                        if (t == typeof(int) || t == typeof(Int32))
                        {
                            int number = 0;
                            int.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(long) || t == typeof(Int64))
                        {
                            long number = 0;
                            long.TryParse(maskedTextBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        break;

                    case "TextBox":
                        TextBox textBox = (TextBox)f.GetValue(form);
                        if (t == typeof(decimal) || t == typeof(Decimal))
                        {
                            decimal number = 0;
                            decimal.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(double) || t == typeof(Double))
                        {
                            double number = 0;
                            double.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(string) || t == typeof(String))
                        {
                            obj.GetType().GetProperty(f.Name).SetValue(obj, textBox.Text, null);
                        }
                        if (t == typeof(int) || t == typeof(Int32))
                        {
                            int number = 0;
                            int.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        if (t == typeof(long) || t == typeof(Int64))
                        {
                            long number = 0;
                            long.TryParse(textBox.Text, out number);
                            obj.GetType().GetProperty(f.Name).SetValue(obj, number, null);
                        }
                        break;
                    case "DateTimePicker":
                        DateTimePicker dateTimePicker = (DateTimePicker)f.GetValue(form);
                        obj.GetType().GetProperty(f.Name).SetValue(obj, dateTimePicker.Value, null);
                        break;
                    case "CheckBox":
                        CheckBox checkBox = (CheckBox)f.GetValue(form);
                        obj.GetType().GetProperty(f.Name).SetValue(obj, checkBox.Checked, null);
                        break;
                    case "ComboBox":
                        ComboBox comboBox = (ComboBox)f.GetValue(form);
                        obj.GetType().GetProperty(f.Name).SetValue(obj, comboBox.SelectedItem, null);
                        break;
                    default:
                        break;
                }
            }

            return obj;
        }

        /// <summary>
        /// Atualiza o Form parâmetro de acordo com o objeto parâmetro, equiparando suas propriedades 
        /// aos campos do formulário.
        /// </summary>
        /// <param name="form">Formulário a ser atualizado.</param>
        /// <param name="obj">Objeto parâmetro</param>
        public static void View(this Form form, object obj)
        {
            if (obj == null)
                throw new Exception("Exceção de objeto nulo.");

            FieldInfo[] formFields = form
                .GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            PropertyInfo[] objProperties = obj
                .GetType()
                .GetProperties();

            foreach (FieldInfo f in formFields)
            {
                if (!objProperties.Select(p => p.Name).Contains(f.Name))
                    continue;

                if (obj.GetType().GetProperty(f.Name).GetValue(obj, null) == null)
                    continue;

                switch (f.FieldType.Name)
                {
                    case "TextBox":
                        String stringValue = (String)obj.GetType().GetProperty(f.Name).GetValue(obj, null);
                        TextBox textBox = (TextBox)f.GetValue(form);
                        textBox.Text = stringValue;
                        break;
                    case "DateTimePicker":
                        DateTime dateTimeValue = (DateTime)obj.GetType().GetProperty(f.Name).GetValue(obj, null);
                        DateTimePicker dateTimePicker = (DateTimePicker)f.GetValue(form);
                        dateTimePicker.Value = dateTimeValue;
                        break;
                    case "CheckBox":
                        Boolean booleanValue = (Boolean)obj.GetType().GetProperty(f.Name).GetValue(obj, null);
                        f.SetValue(form, booleanValue);
                        break;
                    case "ComboBox":
                        Object objectValue = obj.GetType().GetProperty(f.Name).GetValue(obj, null);
                        ComboBox comboBox = (ComboBox)f.GetValue(form);
                        comboBox.SelectedItem = objectValue;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
