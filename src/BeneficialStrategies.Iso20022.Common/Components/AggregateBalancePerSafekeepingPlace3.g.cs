﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AggregateBalancePerSafekeepingPlace3.  ISO2002 ID# _R-_aRdp-Ed-ak6NoX_4Aeg_1472551753.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account at a specified place of safekeeping.
/// </summary>
public partial record AggregateBalancePerSafekeepingPlace3
     : IIsoXmlSerilizable<AggregateBalancePerSafekeepingPlace3>
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding.
    /// </summary>
    public required BalanceQuantity1Choice_ AggregateQuantity { get; init; } 
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is available.
    /// </summary>
    public BalanceQuantity1Choice_? AvailableQuantity { get; init; } 
    /// <summary>
    /// Total quantity of financial instrument for the referenced holding that is not available.
    /// </summary>
    public BalanceQuantity1Choice_? NotAvailableQuantity { get; init; } 
    /// <summary>
    /// Specifies the number of days used for calculating the accrued interest amount.
    /// </summary>
    public IsoNumber? DaysAccrued { get; init; } 
    /// <summary>
    /// Total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? HoldingValue { get; init; } 
    /// <summary>
    /// Previous total value of a balance of the securities account for a specific financial instrument, expressed in one or more currencies.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? PreviousHoldingValue { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? AccruedInterestAmount { get; init; } 
    /// <summary>
    /// Indicates whether the accrued interest is a positive or negative amount.
    /// </summary>
    public IsoPlusOrMinusIndicator? AccruedInterestAmountSign { get; init; } 
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? BookValue { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public required SafekeepingPlaceFormatChoice_ SafekeepingPlace { get; init; } 
    /// <summary>
    /// Price of the financial instrument in one or more currencies.
    /// </summary>
    public PriceInformation2? PriceDetails { get; init; } 
    /// <summary>
    /// Currency exchange related to a securities order.
    /// </summary>
    public ForeignExchangeTerms6? ForeignExchangeDetails { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    public SubBalanceInformation2? BalanceBreakdownDetails { get; init; } 
    /// <summary>
    /// Net position of a segregated holding, in a single security, within the overall position held in a securities account.
    /// </summary>
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "AggtQty", xmlNamespace );
        AggregateQuantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AvailableQuantity is BalanceQuantity1Choice_ AvailableQuantityValue)
        {
            writer.WriteStartElement(null, "AvlblQty", xmlNamespace );
            AvailableQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NotAvailableQuantity is BalanceQuantity1Choice_ NotAvailableQuantityValue)
        {
            writer.WriteStartElement(null, "NotAvlblQty", xmlNamespace );
            NotAvailableQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DaysAccrued is IsoNumber DaysAccruedValue)
        {
            writer.WriteStartElement(null, "DaysAcrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(DaysAccruedValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (HoldingValue is IsoActiveOrHistoricCurrencyAndAmount HoldingValueValue)
        {
            writer.WriteStartElement(null, "HldgVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(HoldingValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (PreviousHoldingValue is IsoActiveOrHistoricCurrencyAndAmount PreviousHoldingValueValue)
        {
            writer.WriteStartElement(null, "PrvsHldgVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(PreviousHoldingValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AccruedInterestAmount is IsoActiveOrHistoricCurrencyAndAmount AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(AccruedInterestAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (AccruedInterestAmountSign is IsoPlusOrMinusIndicator AccruedInterestAmountSignValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmtSgn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPlusOrMinusIndicator(AccruedInterestAmountSignValue)); // data type PlusOrMinusIndicator System.String
            writer.WriteEndElement();
        }
        if (BookValue is IsoActiveOrHistoricCurrencyAndAmount BookValueValue)
        {
            writer.WriteStartElement(null, "BookVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(BookValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
        SafekeepingPlace.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PriceDetails is PriceInformation2 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ForeignExchangeDetails is ForeignExchangeTerms6 ForeignExchangeDetailsValue)
        {
            writer.WriteStartElement(null, "FXDtls", xmlNamespace );
            ForeignExchangeDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BalanceBreakdownDetails is SubBalanceInformation2 BalanceBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "BalBrkdwnDtls", xmlNamespace );
            BalanceBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalBalanceBreakdownDetails is AdditionalBalanceInformation2 AdditionalBalanceBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "AddtlBalBrkdwnDtls", xmlNamespace );
            AdditionalBalanceBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AggregateBalancePerSafekeepingPlace3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
