using GW2Scratch.EVTCAnalytics.Model;
using System;
using System.Collections.Generic;

namespace GW2Scratch.EVTCAnalytics.Processing.Encounters.Results.Health
{
	/// <summary>
	/// A health determiner that always returns the same value.
	/// </summary>
	public class ConstantHealthDeterminer : IHealthDeterminer
	{
		private readonly float? constantValue;

		public ConstantHealthDeterminer(float? constantValue)
		{
			this.constantValue = constantValue;
		}

		public IReadOnlyList<Type> RequiredEventTypes { get; } = new List<Type>();

		public float? GetMainEnemyHealthFraction(Log log)
		{
			return constantValue;
		}
	}
}