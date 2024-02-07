﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashInForecast1.  ISO2002 ID# _VCC7kdp-Ed-ak6NoX_4Aeg_542558277.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash movements into a fund as a result of investment funds transactions, eg, subscriptions or switch-in.
/// </summary>
public partial record CashInForecast1
     : IIsoXmlSerilizable<CashInForecast1>
{
    #nullable enable
    
    /// <summary>
    /// Date on which cash is available.
    /// </summary>
    public required IsoISODate SettlementDate { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as an amount of money.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? SubTotalAmount { get; init; } 
    /// <summary>
    /// Sub-total amount of the cash flow in, expressed as a number of units.
    /// </summary>
    public FinancialInstrumentQuantity1? SubTotalUnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the estimated cash flow in is exceptional.
    /// </summary>
    public IsoYesNoIndicator? ExceptionalCashFlowIndicator { get; init; } 
    /// <summary>
    /// Breakdown of cash in amounts, eg, by transaction and order type.
    /// </summary>
    public FundCashInBreakdown1? CashInBreakdownDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(SettlementDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (SubTotalAmount is IsoActiveOrHistoricCurrencyAndAmount SubTotalAmountValue)
        {
            writer.WriteStartElement(null, "SubTtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(SubTotalAmountValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (SubTotalUnitsNumber is FinancialInstrumentQuantity1 SubTotalUnitsNumberValue)
        {
            writer.WriteStartElement(null, "SubTtlUnitsNb", xmlNamespace );
            SubTotalUnitsNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExceptionalCashFlowIndicator is IsoYesNoIndicator ExceptionalCashFlowIndicatorValue)
        {
            writer.WriteStartElement(null, "XcptnlCshFlowInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ExceptionalCashFlowIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (CashInBreakdownDetails is FundCashInBreakdown1 CashInBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "CshInBrkdwnDtls", xmlNamespace );
            CashInBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CashInForecast1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
