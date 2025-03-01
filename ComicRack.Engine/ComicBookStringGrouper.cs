using cYo.Common.ComponentModel;

namespace cYo.Projects.ComicRack.Engine
{
	public abstract class ComicBookStringGrouper<T> : SingleComicGrouper where T : ComicBookStringMatcher, new()
	{
		public override ComicBookMatcher CreateMatcher(IGroupInfo info)
		{
			T val = new T();
			val.MatchOperator = (info.Caption.Contains(",") ? 6 : 0);
			val.MatchValue = info.Caption;
			return val;
		}
	}
}
