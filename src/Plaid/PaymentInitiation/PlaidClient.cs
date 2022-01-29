namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create a payment recipient for payment initiation.  The recipient must be in Europe, within a country that is a member of the Single Euro Payment Area (SEPA).  For a standing order (recurring) payment, the recipient must be in the UK.</para>
	/// <para>The endpoint is idempotent: if a developer has already made a request with the same payment details, Plaid will return the same <c>recipient_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationrecipientcreate" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationRecipientCreateResponse> PaymentInitiationRecipientCreateAsync(PaymentInitiation.PaymentInitiationRecipientCreateRequest request) =>
		PostAsync("/payment_initiation/recipient/create", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationRecipientCreateResponse>();

	/// <summary>
	/// <para>Reverse a previously initiated payment.</para>
	/// <para>A payment can only be reversed once and will be refunded to the original sender's account.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationpaymentreverse" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationPaymentReverseResponse> PaymentInitiationPaymentReverseAsync(PaymentInitiation.PaymentInitiationPaymentReverseRequest request) =>
		PostAsync("/payment_initiation/payment/reverse", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationPaymentReverseResponse>();

	/// <summary>
	/// <para>Get details about a payment recipient you have previously created.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationrecipientget" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationRecipientGetResponse> PaymentInitiationRecipientGetAsync(PaymentInitiation.PaymentInitiationRecipientGetRequest request) =>
		PostAsync("/payment_initiation/recipient/get", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationRecipientGetResponse>();

	/// <summary>
	/// <para>The <c>/payment_initiation/recipient/list</c> endpoint list the payment recipients that you have previously created.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationrecipientlist" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationRecipientListResponse> PaymentInitiationRecipientListAsync(PaymentInitiation.PaymentInitiationRecipientListRequest request) =>
		PostAsync("/payment_initiation/recipient/list", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationRecipientListResponse>();

	/// <summary>
	/// <para>After creating a payment recipient, you can use the <c>/payment_initiation/payment/create</c> endpoint to create a payment to that recipient.  Payments can be one-time or standing order (recurring) and can be denominated in either EUR or GBP.  If making domestic GBP-denominated payments, your recipient must have been created with BACS numbers. In general, EUR-denominated payments will be sent via SEPA Credit Transfer and GBP-denominated payments will be sent via the Faster Payments network, but the payment network used will be determined by the institution. Payments sent via Faster Payments will typically arrive immediately, while payments sent via SEPA Credit Transfer will typically arrive in one business day.</para>
	/// <para>Standing orders (recurring payments) must be denominated in GBP and can only be sent to recipients in the UK. Once created, standing order payments cannot be modified or canceled via the API. An end user can cancel or modify a standing order directly on their banking application or website, or by contacting the bank. Standing orders will follow the payment rules of the underlying rails (Faster Payments in UK). Payments can be sent Monday to Friday, excluding bank holidays. If the pre-arranged date falls on a weekend or bank holiday, the payment is made on the next working day. It is not possible to guarantee the exact time the payment will reach the recipient’s account, although at least 90% of standing order payments are sent by 6am.</para>
	/// <para>In the Development environment, payments must be below 5 GBP / EUR. For details on any payment limits in Production, contact your Plaid Account Manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationpaymentcreate" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationPaymentCreateResponse> PaymentInitiationPaymentCreateAsync(PaymentInitiation.PaymentInitiationPaymentCreateRequest request) =>
		PostAsync("/payment_initiation/payment/create", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationPaymentCreateResponse>();

	/// <summary>
	/// <para>The <c>/payment_initiation/payment/token/create</c> endpoint has been deprecated. New Plaid customers will be unable to use this endpoint, and existing customers are encouraged to migrate to the newer, <c>link_token</c>-based flow. The recommended flow is to provide the <c>payment_id</c> to <c>/link/token/create</c>, which returns a <c>link_token</c> used to initialize Link.</para>
	/// <para>The <c>/payment_initiation/payment/token/create</c> is used to create a <c>payment_token</c>, which can then be used in Link initialization to enter a payment initiation flow. You can only use a <c>payment_token</c> once. If this attempt fails, the end user aborts the flow, or the token expires, you will need to create a new payment token. Creating a new payment token does not require end user input.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/link/maintain-legacy-integration/#creating-a-payment-token" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationPaymentTokenCreateResponse> PaymentInitiationPaymentTokenCreateAsync(PaymentInitiation.PaymentInitiationPaymentTokenCreateRequest request) =>
		PostAsync("/payment_initiation/payment/token/create", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationPaymentTokenCreateResponse>();

	/// <summary>
	/// <para>The <c>/payment_initiation/payment/get</c> endpoint can be used to check the status of a payment, as well as to receive basic information such as recipient and payment amount. In the case of standing orders, the <c>/payment_initiation/payment/get</c> endpoint will provide information about the status of the overall standing order itself; the API cannot be used to retrieve payment status for individual payments within a standing order.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationpaymentget" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationPaymentGetResponse> PaymentInitiationPaymentGetAsync(PaymentInitiation.PaymentInitiationPaymentGetRequest request) =>
		PostAsync("/payment_initiation/payment/get", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationPaymentGetResponse>();

	/// <summary>
	/// <para>The <c>/payment_initiation/payment/list</c> endpoint can be used to retrieve all created payments. By default, the 10 most recent payments are returned. You can request more payments and paginate through the results using the optional <c>count</c> and <c>cursor</c> parameters.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/#payment_initiationpaymentlist" /></remarks>
	public Task<PaymentInitiation.PaymentInitiationPaymentListResponse> PaymentInitiationPaymentListAsync(PaymentInitiation.PaymentInitiationPaymentListRequest request) =>
		PostAsync("/payment_initiation/payment/list", request)
			.ParseResponseAsync<PaymentInitiation.PaymentInitiationPaymentListResponse>();
}