public class skovoroda {

	private salt salt;
	private maslo maslo;
	private milk milk;
	private egg[] eggs;
	private int temperature = 0;

	public void Init(int counteggs) {
		eggs = new egg[counteggs];
	}

	public void AddMilk(milk w) {
		milk = w;
	}

	public void AddSalt(salt s) {
		salt = s;
	}

	public void AddMaslo(maslo m) {
		maslo = m;
	}

	public boolean readyToGo() {
		return Check();
	}
	
	public void AddEggs(egg e)
    {
        for (int i =0; i< eggs.length; ++i)
        {
            if (eggs[i] == null)
            {
                eggs[i] = e;
                return;
            }
        }
    }
	
	public boolean Check() {
		if (eggs.length == 0) {
			return false;
		}
		for (int i = 0; i < eggs.length; ++i) {
			if (eggs[i] == null) {
				return false;
			}
		}

		return true;
	}
	
	public void GetHeat()
    {
        while (temperature < 250)
        {
            temperature++;
        }
        for(int i = 0; i < eggs.length; ++i)
        {
            eggs[i].heat();
        }
        if (!Check())
        {
            return;
        }
    }

    public boolean IsReady()
    {
        if (temperature < 250) {
            return false;
        }
        for (int i = 0; i < eggs.length; ++i)
            {
                if(eggs[i].getReady() < 10)
                    {
                        return false;
                    }
            }
        return true;
    }

    public egg[] GetEggs()
    {
        return eggs;
    }
}
