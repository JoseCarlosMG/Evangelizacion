namespace Sysne.Core.MVVM.Helpers
{
    public static class Cloner
    {
        public static T Clone<T>(this T source) where T : new()
        {
            if (source == null) return default;
            var target = new T();

            foreach (var prop in source.GetType().GetProperties())
            {
                prop.SetValue(target, prop.GetValue(source));
            }

            return target;
        }

        public static void CloneTo<T>(this T source, ref T target) where T : new()
        {
            if (source == null) return;

            foreach (var prop in source.GetType().GetProperties())
            {
                prop.SetValue(target, prop.GetValue(source));
            }

        }
    }
}