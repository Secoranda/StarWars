namespace Labs
{
	public partial interface IStormtrooper
	{
		string Fight(IStormtrooperFighting fighting);
	}

	public partial class Stormtrooper
	{
		public string Fight(IStormtrooperFighting fighting)
		{
			return fighting.Fight();
		}
	}

	public interface IStormtrooperFighting
	{
		string Fight();
	}

	public class StormtrooperFighting : IStormtrooperFighting
	{
		public IRangeWeapon weapon;

		public StormtrooperFighting(IRangeWeapon weapon)
		{
			this.weapon = weapon;
		}

		public string Fight()
		{
			return weapon.Shoot();
		}
	}

	public interface IRangeWeapon
	{
		string Shoot();
	}

	public class RangeWeapon : IRangeWeapon
	{
		public string Shoot()
		{
			return "Shots fired. All missed.";
		}
	}

	public interface IMeleeWeapon
	{
		string Cut();
	}

	public class MeleeWeapon : IMeleeWeapon
	{
		public string Cut()
		{
			return "Cuts through flesh. Misses.";
		}
	}

	public class MeleeToRangeAdapter : IRangeWeapon
	{
		public IMeleeWeapon meleeWeapon;

		public MeleeToRangeAdapter(IMeleeWeapon melee)
		{
			meleeWeapon = melee;
		}

		public string Shoot()
		{
			return meleeWeapon.Cut();
		}
	}

	public class StormtrooperSpecialAttackDecorator : IStormtrooperFighting
	{
		private IStormtrooperFighting _fighting;

		public StormtrooperSpecialAttackDecorator(IStormtrooperFighting fighting)
		{
			_fighting = fighting;
		}

		public string Fight()
		{
			return "Special Attack. Combo x20 missed.\n" + _fighting.Fight();
		}
	}
}
