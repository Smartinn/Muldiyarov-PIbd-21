import java.io.Serializable;
import java.util.Iterator;
import java.util.Dictionary;
import java.util.Hashtable;

public class ClassShop<T extends Interface> implements Serializable,
		Iterable<T>, Iterator<T>, Comparable<ClassShop<T>> {

	private T defaultValue;
	private Dictionary<Integer, T> places;
	int maxCount;

	public ClassShop(int sizes, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = sizes;
	}

	public static <T extends Interface> int plus(ClassShop<T> p, T git)
			throws ShopOverflowException, ShopAlreadyHaveException {
		boolean isGit = git instanceof Gitara;
		if (p.places.size() == p.maxCount)
			throw new ShopOverflowException();
		int index = p.places.size();
		for (int i = 0; i < p.places.size(); i++) {
			if (p.checkFree(i)) {
				index = i;
			}
			if (git.getClass() == p.places.get(i).getClass()) {
				if (isGit) {
					if (((Gitara) git).equals(p.places.get(i))) {
						throw new ShopAlreadyHaveException();
					}
				} else if (((Sounds) git).equals(p.places.get(i))) {
					throw new ShopAlreadyHaveException();
				}
			}
		}
		if (index != p.places.size()) {
			p.places.put(index, git);
			return index;
		}
		p.places.put(p.places.size(), git);
		return p.places.size() - 1;
	}

	public static <T extends Interface> T minus(ClassShop<T> p, int index)
			throws ShopIndexOutOfRangeException {
		if (p.places.get(index) != null) {
			T plane = p.places.get(index);
			p.places.remove(index);
			return plane;
		}
		throw new ShopIndexOutOfRangeException();

	}

	public boolean checkFree(int index) {
		if (places.get(index) == null)
			return true;
		return false;
	}

	public T getGit(int ind) {
		if (places.get(ind) != null)
			return places.get(ind);
		return defaultValue;
	}

	private int currentIndex;

	@Override
	public int compareTo(ClassShop<T> arg0) {
		// TODO Auto-generated method stub
		if (places.size() > arg0.places.size())
			return -1;
		else if (places.size() < arg0.places.size())
			return 1;
		else {
			for (int i = 0; i < places.size(); i++) {
				if ((places.get(places.keys().nextElement()) instanceof Gitara)
						&& (arg0.places.get(arg0.places.keys().nextElement()) instanceof Gitara)) {
					return (((Gitara) places.get(places.keys().nextElement()))
							.compareTo(((Gitara) arg0.places.get(arg0.places
									.keys().nextElement()))));
				}
				if ((places.get(places.keys().nextElement()) instanceof Sounds)
						&& (arg0.places.get(arg0.places.keys().nextElement()) instanceof Gitara))
					return 1;
				if ((places.get(places.keys().nextElement()) instanceof Gitara)
						&& (arg0.places.get(arg0.places.keys().nextElement()) instanceof Sounds))
					return -1;
				if ((places.get(places.keys().nextElement()) instanceof Sounds)
						&& (arg0.places.get(arg0.places.keys().nextElement()) instanceof Sounds)) {
					return (((Sounds) places.get(places.keys().nextElement()))
							.compareTo(((Sounds) arg0.places.get(arg0.places
									.keys().nextElement()))));
				}

			}
		}

		return 0;
	}

	@Override
	public boolean hasNext() {
		if (currentIndex + 1 >= places.size()) {
			currentIndex = -1;
			return false;
		}
		currentIndex++;
		return true;
	}

	@Override
	public T next() {
		// TODO Auto-generated method stub
		return (T) places.get(currentIndex);
	}

	@Override
	public Iterator<T> iterator() {
		// TODO Auto-generated method stub
		return this;
	}
}
