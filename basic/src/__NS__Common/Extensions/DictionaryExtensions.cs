namespace __NS__Common.Extensions
{
	using System.Collections.Generic;

	public static class DictionaryExtensions
	{
		public static TValue TryGetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			return TryGetValue(dictionary, key, default(TValue));
		}

		public static TValue TryGetValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			TValue value;
			if (dictionary.TryGetValue(key, out value))
			{
				return value;
			}

			return defaultValue;
		}
	}
}
