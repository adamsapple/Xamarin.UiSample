using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace UiSample.Views
{
    public class ContentPageEx : ContentPage
    {
        protected IEnumerable<View> GetContentElements()
        {
            var content = Content as Layout<View>;

            if (content == null)
            {
                Enumerable.Empty<View>();
            }

            return content.Children
                          .Traverse(x => x is Layout<View> layout ? layout.Children : Enumerable.Empty<View>());
        }

        protected void GoToStateAllElements(string state)
        {
            var elements = GetContentElements().Where(x => x.HasVisualStateGroups());

            foreach (var element in elements)
            {
                VisualStateManager.GoToState(element, state);
            }
        }

    }
    public static class IEnumerableExtension
    {
        public static IEnumerable<T> Traverse<T>(this IEnumerable<T> items,
                                                 Func<T, IEnumerable<T>> childSelector)
        {
            var stack = new Stack<T>(items);
            while (stack.Any())
            {
                var next = stack.Pop();
                yield return next;

                foreach (var child in childSelector(next))
                {
                    stack.Push(child);
                }
            }
        }
    }
}
