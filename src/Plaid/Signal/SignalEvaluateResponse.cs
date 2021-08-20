namespace Going.Plaid.Signal;

/// <summary>
/// 
/// </summary>
public record SignalEvaluateResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("scores")]
	public Entity.SignalEvaluateScores Scores { get; init; } = default!;

	/// <summary>
	/// <para>The core attributes object contains additional data that can be used to assess the ACH return risk, such as past ACH return events, balance/transaction history, the Item’s connection history in the Plaid network, and identity change history.</para>
	/// </summary>
	[JsonPropertyName("core_attributes")]
	public Entity.SignalEvaluateCoreAttributes CoreAttributes { get; init; } = default!;
}