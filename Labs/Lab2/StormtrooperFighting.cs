using System;

namespace Labs
{
	public partial interface IStormtrooper
	{
		void Fight(IStormtrooperFighting fighting);
	}

	public partial class Stormtrooper
	{
		public void Fight(IStormtrooperFighting fighting)
		{
			fighting.Fight();
		}
	}

	public interface IStormtrooperFighting
	{
		void Fight();
	}

	public class StormtrooperFighting : IStormtrooperFighting
	{
		public IRangeWeapon weapon;

		public StormtrooperFighting(IRangeWeapon weapon)
		{
			this.weapon = weapon;
		}

		public void Fight()
		{
			weapon.Shoot();
		}
	}

	public interface IRangeWeapon
	{
		void Shoot();
	}

	public class RangeWeapon : IRangeWeapon
	{
		public void Shoot()
		{
			Console.WriteLine("Shots fired. All missed.");
		}
	}

	public interface IMeleeWeapon
	{
		void Cut();
	}

	public class MeleeWeapon : IMeleeWeapon
	{
		public void Cut()
		{
			Console.WriteLine("Cuts through flesh. Misses.");
		}
	}

	public class MeleeToRangeAdapter : IRangeWeapon
	{
		public IMeleeWeapon meleeWeapon;

		public MeleeToRangeAdapter(IMeleeWeapon melee)
		{
			meleeWeapon = melee;
		}

		public void Shoot()
		{
			meleeWeapon.Cut();
		}
	}

	public class StormtrooperSpecialAttackDecorator : IStormtrooperFighting
	{
		private IStormtrooperFighting _fighting;

		public StormtrooperSpecialAttackDecorator(IStormtrooperFighting fighting)
		{
			_fighting = fighting;
		}

		public void Fight()
		{
			Console.WriteLine("Special Attack. Combo x20 missed.");
			_fighting.Fight();
		}
	}
}
