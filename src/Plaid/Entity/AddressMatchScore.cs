namespace Going.Plaid.Entity;

/// <summary>
/// <para>Score found by matching address provided by the API with the address on the account at the financial institution. The score can range from 0 to 100 where 100 is a perfect match and 0 is a no match. If the account contains multiple owners, the maximum match score is filled.</para>
/// </summary>
public record AddressMatchScore
{
	/// <summary>
	/// <para>Match score for address. 100 is a perfect match, 99-90 is a strong match, 89-70 is a partial match, anything below 70 is considered a weak match. Typically, the match threshold should be set to a score of 70 or higher. If the address is missing from either the API or financial institution, this is null.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>postal code was provided for both and was a match</para>
	/// </summary>
	[JsonPropertyName("is_postal_code_match")]
	public bool? IsPostalCodeMatch { get; init; } = default!;
}