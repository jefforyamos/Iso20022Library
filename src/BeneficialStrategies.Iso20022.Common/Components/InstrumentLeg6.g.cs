﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InstrumentLeg6.  ISO2002 ID# _Na1yQQ8qEeSFHsNYty4C9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additionnal details related to the leg.
/// </summary>
public partial record InstrumentLeg6
     : IIsoXmlSerilizable<InstrumentLeg6>
{
    #nullable enable
    
    /// <summary>
    /// Coded list to specify the side of the trade leg.
    /// </summary>
    public required Side1Code LegSide { get; init; } 
    /// <summary>
    /// Specifies the date of settlement, in coded form.
    /// </summary>
    public required SettlementDateCode LegSettlementType { get; init; } 
    /// <summary>
    /// Specifies the date and time on which the trade will be settled.
    /// </summary>
    public required IsoISODateTime LegSettlementDate { get; init; } 
    /// <summary>
    /// Execution price of trade leg.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount LegLastPrice { get; init; } 
    /// <summary>
    /// Settlement currency of trade leg, agreed by both sides of the trade.
    /// </summary>
    public required CurrencyCode LegSettlementCurrency { get; init; } 
    /// <summary>
    /// Amount of trade leg in trading currency.
    /// </summary>
    public required IsoCurrencyAndAmount LegOrderQuantity { get; init; } 
    /// <summary>
    /// Forward points added to last spot rate. May be a negative value. Expressed in decimal form.
    /// </summary>
    public required IsoDecimalNumber LegForwardPoints { get; init; } 
    /// <summary>
    /// Used for the calculated quantity of the other side of the currency trade. Can be derived from leg order quantity and leg last price.
    /// </summary>
    public required IsoCurrencyAndAmount LegCalculatedCounterpartyCurrencyLastQuantity { get; init; } 
    /// <summary>
    /// Measurement of the leg trade values in terms of a currency (for example, the amount of trade in US dollars).
    /// </summary>
    public required IsoActiveCurrencyAndAmount LegRiskAmount { get; init; } 
    /// <summary>
    /// Specifies the valuation rate used for the trade leg.
    /// </summary>
    public required AgreedRate3 LegValuationRate { get; init; } 
    /// <summary>
    /// Specifies the value date of leg spot transaction.
    /// </summary>
    public required IsoISODate LegValueDate { get; init; } 
    /// <summary>
    /// Currency trade is conducted.
    /// </summary>
    public required CurrencyCode LegCurrency { get; init; } 
    /// <summary>
    /// Symbol of the leg trade.
    /// </summary>
    public required IsoMax35Text LegSymbol { get; init; } 
    /// <summary>
    /// Security identification of the leg trade.
    /// </summary>
    public required SecurityIdentification18 LegSecurityIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "LegSd", xmlNamespace );
        writer.WriteValue(LegSide.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegSttlmTp", xmlNamespace );
        writer.WriteValue(LegSettlementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegSttlmDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(LegSettlementDate)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegLastPric", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(LegLastPrice)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegSttlmCcy", xmlNamespace );
        writer.WriteValue(LegSettlementCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegOrdrQty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(LegOrderQuantity)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegFwdPts", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoDecimalNumber(LegForwardPoints)); // data type DecimalNumber System.UInt64
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegClctdCtrPtyCcyLastQty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(LegCalculatedCounterpartyCurrencyLastQuantity)); // data type CurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegRskAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(LegRiskAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegValtnRate", xmlNamespace );
        LegValuationRate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(LegValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegCcy", xmlNamespace );
        writer.WriteValue(LegCurrency.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegSymb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(LegSymbol)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "LegSctyId", xmlNamespace );
        LegSecurityIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static InstrumentLeg6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
