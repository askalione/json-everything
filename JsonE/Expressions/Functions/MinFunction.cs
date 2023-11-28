﻿using System.Linq;
using System.Text.Json.Nodes;
using Json.JsonE.Operators;
using Json.More;

namespace Json.JsonE.Expressions.Functions;

internal class MinFunction : FunctionDefinition
{
	private const string _name = "min";

	internal override JsonNode? Invoke(JsonNode?[] arguments, EvaluationContext context)
	{
		var nums = arguments.Select(x => (x as JsonValue)?.GetNumber()).ToArray();
		if (nums.Any(x => !x.HasValue))
			throw new BuiltInException(CommonErrors.IncorrectArgType(_name));

		return nums.Min();
	}
}