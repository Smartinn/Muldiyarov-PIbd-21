public class ShopAlreadyHaveException extends Exception {
	
	public ShopAlreadyHaveException(){
		super("Такой товар уже имеется");
	}
}
