namespace Going.Plaid.Entity;

/// <summary>
/// <para>Base Report information about an account</para>
/// </summary>
public record BaseReportAccount
{
	/// <summary>
	/// <para>Base Report information about an account's balances</para>
	/// </summary>
	[JsonPropertyName("balances")]
	public Entity.BaseReportAccountBalances Balances { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account, either assigned by the user or by the financial institution itself</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the account as given by the financial institution</para>
	/// </summary>
	[JsonPropertyName("official_name")]
	public string? OfficialName { get; init; } = default!;

	/// <summary>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</a> for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.AccountType Type { get; init; } = default!;

	/// <summary>
	/// <para>See the [Account type schema](https://plaid.com/docs/api/accounts/#account-type-schema) for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public Entity.AccountSubtype? Subtype { get; init; } = default!;

	/// <summary>
	/// <para>The duration of transaction history available for this Item, typically defined as the time since the date of the earliest transaction in that account. Only returned by Base Report endpoints.</para>
	/// </summary>
	[JsonPropertyName("days_available")]
	public decimal DaysAvailable { get; init; } = default!;

	/// <summary>
	/// <para>Transaction history associated with the account. Only returned by Base Report endpoints. Transaction history returned by endpoints such as <c>/transactions/get</c> or <c>/investments/transactions/get</c> will be returned in the top-level <c>transactions</c> field instead.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.BaseReportTransaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array.</para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner> Owners { get; init; } = default!;

	/// <summary>
	/// <para>How an asset is owned.</para>
	/// </summary>
	[JsonPropertyName("ownership_type")]
	public Entity.OwnershipType? OwnershipType { get; init; } = default!;

	/// <summary>
	/// <para>Calculated data about the historical balances on the account. Only returned by Base Report endpoints and currently not supported by <c>brokerage</c> or <c>investment</c> accounts.</para>
	/// </summary>
	[JsonPropertyName("historical_balances")]
	public IReadOnlyList<Entity.HistoricalBalance> HistoricalBalances { get; init; } = default!;

	/// <summary>
	/// <para>Calculated insights derived from transaction-level data.</para>
	/// </summary>
	[JsonPropertyName("account_insights")]
	public Entity.BaseReportAccountInsights? AccountInsights { get; init; } = default!;

}
