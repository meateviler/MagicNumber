namespace MagicNumber
{
    public class ShowPageController
    {
        public ActionResult Index(int page)
        {
            var items = MyRepository.GetItems().ToPagedList(page, 20);

            return View(items);
        }

        private ActionResult View(object items)
        {
            throw new System.NotImplementedException();
        }
    }

    public class MyRepository
    {
        public static Items GetItems()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Items
    {
        public object ToPagedList(int page, int PageSize)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ActionResult
    {
    }
}