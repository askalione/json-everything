﻿using System.Text.Json;
using Json.More;

namespace Json.Logic
{
	internal class LooseEqualsComponent : ILogicComponent
	{
		private readonly ILogicComponent _a;
		private readonly ILogicComponent _b;

		public LooseEqualsComponent(ILogicComponent a, ILogicComponent b)
		{
			_a = a;
			_b = b;
		}

		public JsonElement Apply(JsonElement data)
		{
			return _a.Apply(data).IsEquivalentTo(_b.Apply(data)).AsJsonElement();
		}
	}
}