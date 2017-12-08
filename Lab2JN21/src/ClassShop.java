import java.util.Dictionary;
import java.util.Hashtable;

public class ClassShop<T extends Interface> {

	private T defaultValue;
	private Dictionary<Integer, T> places;
	int maxCount;

	public ClassShop(int sizes, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = sizes;
	}

	public static <T extends Interface> int plus(ClassShop<T> p, T plane)
	{
		if (p.places.size() == p.maxCount) return -1;
		for(int i = 0; i < p.places.size(); i++)
		{
			if (p.checkFree(i))
			{
				p.places.put(i, plane);
				return i;
			}
		}
		p.places.put(p.places.size(), plane);
		return p.places.size() - 1;
	}

	public static <T extends Interface> T minus(ClassShop<T> p, int index)
	{
		if (p.places.get(index) != null)
		{
			T plane = p.places.get(index);
			p.places.remove(index);
			return plane;
		}
		return p.defaultValue;
	}

	public boolean checkFree(int index)
	{
		if(places.get(index)==null) return true;
		return false;
	}
	
	
	public T getGit(int ind) {
		if(places.get(ind)!=null) return places.get(ind);
		return defaultValue;
	}
}
