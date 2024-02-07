﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalanceInformation38.  ISO2002 ID# _Z0x7r_fVEeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall position, in a single security, held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalanceInformation38
     : IIsoXmlSerilizable<AggregateBalanceInformation38>
{
    #nullable enable
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Elements characterising an investment funds financial instrument.
    /// </summary>
    public FinancialInstrument22? InvestmentFundsFinancialInstrumentAttributes { get; init; } 
    /// <summary>
    /// Details of the swap contract.
    /// </summary>
    public DerivativeBasicAttributes2? AdditionalDerivativeAttributes { get; init; } 
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    public required Balance10 AggregateBalance { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace4? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public CorporateActionOption5Code? CorporateActionOptionType { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation22? PriceDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Z0x76_fVEeiNZp_PtLohLw
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    public ForeignExchangeTerms35? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the base currency of the account.
    /// </summary>
    public required BalanceAmounts5 AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts5? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts provided in a currency other than the base currency of the account.
    /// </summary>
    public BalanceAmounts5? AlternateReportingCurrencyAmounts { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown55? QuantityBreakdown { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate balance per meaningful sub-balances and availability.
    /// </summary>
    public SubBalanceInformation16? BalanceBreakdown { get; init; } 
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation16? AdditionalBalanceBreakdown { get; init; } 
    /// <summary>
    /// Breakdown of positions per place of safekeeping (and optionally per place of listing).
    /// </summary>
    public AggregateBalancePerSafekeepingPlace35? BalanceAtSafekeepingPlace { get; init; } 
    /// <summary>
    /// Provides additional information on the holding.
    /// </summary>
    public IsoRestrictedFINXMax350Text? HoldingAdditionalDetails { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (FinancialInstrumentAttributes is FinancialInstrumentAttributes97 FinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "FinInstrmAttrbts", xmlNamespace );
            FinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InvestmentFundsFinancialInstrumentAttributes is FinancialInstrument22 InvestmentFundsFinancialInstrumentAttributesValue)
        {
            writer.WriteStartElement(null, "InvstmtFndsFinInstrmAttrbts", xmlNamespace );
            InvestmentFundsFinancialInstrumentAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalDerivativeAttributes is DerivativeBasicAttributes2 AdditionalDerivativeAttributesValue)
        {
            writer.WriteStartElement(null, "AddtlDerivAttrbts", xmlNamespace );
            AdditionalDerivativeAttributesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AggtBal", xmlNamespace );
        AggregateBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SafekeepingPlace is SafeKeepingPlace4 SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CorporateActionOptionType is CorporateActionOption5Code CorporateActionOptionTypeValue)
        {
            writer.WriteStartElement(null, "CorpActnOptnTp", xmlNamespace );
            writer.WriteValue(CorporateActionOptionTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        // Not sure how to serialize PriceDetails, multiplicity Unknown
        if (ForeignExchangeDetails is ForeignExchangeTerms35 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DaysAccrued is IsoNumber DaysAccruedValue)
        {
            writer.WriteStartElement(null, "DaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(DaysAccruedValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AcctBaseCcyAmts", xmlNamespace );
        AccountBaseCurrencyAmounts.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (InstrumentCurrencyAmounts is BalanceAmounts5 InstrumentCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "InstrmCcyAmts", xmlNamespace );
            InstrumentCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AlternateReportingCurrencyAmounts is BalanceAmounts5 AlternateReportingCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "AltrnRptgCcyAmts", xmlNamespace );
            AlternateReportingCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuantityBreakdown is QuantityBreakdown55 QuantityBreakdownValue)
        {
            writer.WriteStartElement(null, "QtyBrkdwn", xmlNamespace );
            QuantityBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceBreakdown is SubBalanceInformation16 BalanceBreakdownValue)
        {
            writer.WriteStartElement(null, "BalBrkdwn", xmlNamespace );
            BalanceBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalBalanceBreakdown is AdditionalBalanceInformation16 AdditionalBalanceBreakdownValue)
        {
            writer.WriteStartElement(null, "AddtlBalBrkdwn", xmlNamespace );
            AdditionalBalanceBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceAtSafekeepingPlace is AggregateBalancePerSafekeepingPlace35 BalanceAtSafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "BalAtSfkpgPlc", xmlNamespace );
            BalanceAtSafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (HoldingAdditionalDetails is IsoRestrictedFINXMax350Text HoldingAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "HldgAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax350Text(HoldingAdditionalDetailsValue)); // data type RestrictedFINXMax350Text System.String
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AggregateBalanceInformation38 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
