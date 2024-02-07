﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityBreakdown4.  ISO2002 ID# _TAtV-Np-Ed-ak6NoX_4Aeg_-597663942.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of breakdown of a quantity.
/// </summary>
public partial record QuantityBreakdown4
     : IIsoXmlSerilizable<QuantityBreakdown4>
{
    #nullable enable
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    public Number2Choice_? LotNumber { get; init; } 
    /// <summary>
    /// Quantity of financial instruments that is part of the lot described.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? LotQuantity { get; init; } 
    /// <summary>
    /// Date/time at which the lot was purchased.
    /// </summary>
    public DateAndDateTimeChoice_? LotDateTime { get; init; } 
    /// <summary>
    /// Price at which the lot was purchased.
    /// </summary>
    public Price2? LotPrice { get; init; } 
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public TypeOfPrice3Choice_? TypeOfPrice { get; init; } 
    /// <summary>
    /// Valuation amounts for the lot provided in the base currency of the account.
    /// </summary>
    public BalanceAmounts2? AccountBaseCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts for the lot provided in the currency of the financial instrument.
    /// </summary>
    public BalanceAmounts2? InstrumentCurrencyAmounts { get; init; } 
    /// <summary>
    /// Valuation amounts for the lot provided in another currency than the base currency of the account.
    /// </summary>
    public BalanceAmounts2? AlternateReportingCurrencyAmounts { get; init; } 
    
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
        if (LotNumber is Number2Choice_ LotNumberValue)
        {
            writer.WriteStartElement(null, "LotNb", xmlNamespace );
            LotNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotQuantity is FinancialInstrumentQuantity1Choice_ LotQuantityValue)
        {
            writer.WriteStartElement(null, "LotQty", xmlNamespace );
            LotQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotDateTime is DateAndDateTimeChoice_ LotDateTimeValue)
        {
            writer.WriteStartElement(null, "LotDtTm", xmlNamespace );
            LotDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (LotPrice is Price2 LotPriceValue)
        {
            writer.WriteStartElement(null, "LotPric", xmlNamespace );
            LotPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TypeOfPrice is TypeOfPrice3Choice_ TypeOfPriceValue)
        {
            writer.WriteStartElement(null, "TpOfPric", xmlNamespace );
            TypeOfPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountBaseCurrencyAmounts is BalanceAmounts2 AccountBaseCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "AcctBaseCcyAmts", xmlNamespace );
            AccountBaseCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstrumentCurrencyAmounts is BalanceAmounts2 InstrumentCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "InstrmCcyAmts", xmlNamespace );
            InstrumentCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AlternateReportingCurrencyAmounts is BalanceAmounts2 AlternateReportingCurrencyAmountsValue)
        {
            writer.WriteStartElement(null, "AltrnRptgCcyAmts", xmlNamespace );
            AlternateReportingCurrencyAmountsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static QuantityBreakdown4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
