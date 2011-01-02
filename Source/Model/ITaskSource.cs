namespace Igoriok.Tagre.Model
{
    using System.Collections.Generic;

    public interface ITaskSource
    {
        IList<Task> GetAll();
    }
}
