using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace TioPatinhasRecursos.Atributos
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AtLeastOnePropertyAttribute : ValidationAttribute
    {
        private string[] PropertyList { get; }

        public AtLeastOnePropertyAttribute(params string[] propertyList)
        {
            PropertyList = propertyList;
            ErrorMessage = "Informe pelos menos um dos seguintes parâmetros: " + string.Join(", ", propertyList);
        }

        public override object TypeId => this;

        public override bool IsValid(object value) => PropertyList.Select(propertyName => value.GetType().GetProperty(propertyName)).Any(propertyInfo => propertyInfo?.GetValue(value, null) != null);
    }
}
