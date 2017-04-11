using System.Collections;
using System.Linq;
using System.Web.Http.ModelBinding;

namespace TioPatinhasRecursos.Extensoes
{
    public static class ModelStateExtensions
    {
        public static IEnumerable Errors(this ModelStateDictionary modelState)
        {
            return modelState.Values.SelectMany(x => x.Errors.Select(y => y.ErrorMessage));
        }
    }
}