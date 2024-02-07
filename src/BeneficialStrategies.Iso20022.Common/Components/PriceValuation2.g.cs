﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceValuation2.  ISO2002 ID# _Vbrjn9p-Ed-ak6NoX_4Aeg_-213723155.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Calculation of the net asset value for an investment fund/fund class.
/// </summary>
public partial record PriceValuation2
     : IIsoXmlSerilizable<PriceValuation2>
{
    #nullable enable
    
    /// <summary>
    /// Unique technical identifier for an instance of a price valuation within a price report, as assigned by the issuer of the report.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Date and time of the price valuation for the investment fund/fund class.
    /// </summary>
    public DateAndDateTimeChoice_? ValuationDateTime { get; init; } 
    /// <summary>
    /// Date and time at which a price is applied, according to the terms stated in the prospectus.
    /// </summary>
    public required DateAndDateTimeChoice_ TradeDateTime { get; init; } 
    /// <summary>
    /// Investment fund class for which the net asset value is calculated.
    /// </summary>
    public required FinancialInstrument5 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Value of all the holdings, less the fund's liabilities, attributable to a specific investment fund class.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalNAV { get; init; } 
    /// <summary>
    /// Total number of investment fund class units that have been issued.
    /// </summary>
    public FinancialInstrumentQuantity1? TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Date and time of the next price valuation for the investment fund/fund class.
    /// </summary>
    public DateAndDateTimeChoice_? NextValuationDateTime { get; init; } 
    /// <summary>
    /// Date and time of the previous price valuation for the investment fund/fund class.
    /// </summary>
    public DateAndDateTimeChoice_? PreviousValuationDateTime { get; init; } 
    /// <summary>
    /// Specifies how the valuation is done, based on the schedule stated in the prospectus.
    /// </summary>
    public required ValuationTiming1Code ValuationCycle { get; init; } 
    /// <summary>
    /// Indicates whether the valuation of the investment fund class is suspended.
    /// </summary>
    public required IsoYesNoIndicator SuspendedIndicator { get; init; } 
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    public UnitPrice6? PriceDetails { get; init; } 
    /// <summary>
    /// Information related to the price variations of an investment fund class.
    /// </summary>
    public ValuationStatistics2? ValuationStatistics { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ValuationDateTime is DateAndDateTimeChoice_ ValuationDateTimeValue)
        {
            writer.WriteStartElement(null, "ValtnDtTm", xmlNamespace );
            ValuationDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TradDtTm", xmlNamespace );
        TradeDateTime.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
        FinancialInstrumentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TotalNAV is IsoActiveOrHistoricCurrencyAndAmount TotalNAVValue)
        {
            writer.WriteStartElement(null, "TtlNAV", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(TotalNAVValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalUnitsNumber is FinancialInstrumentQuantity1 TotalUnitsNumberValue)
        {
            writer.WriteStartElement(null, "TtlUnitsNb", xmlNamespace );
            TotalUnitsNumberValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NextValuationDateTime is DateAndDateTimeChoice_ NextValuationDateTimeValue)
        {
            writer.WriteStartElement(null, "NxtValtnDtTm", xmlNamespace );
            NextValuationDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousValuationDateTime is DateAndDateTimeChoice_ PreviousValuationDateTimeValue)
        {
            writer.WriteStartElement(null, "PrvsValtnDtTm", xmlNamespace );
            PreviousValuationDateTimeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ValtnCycl", xmlNamespace );
        writer.WriteValue(ValuationCycle.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SspdInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SuspendedIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (PriceDetails is UnitPrice6 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValuationStatistics is ValuationStatistics2 ValuationStatisticsValue)
        {
            writer.WriteStartElement(null, "ValtnSttstcs", xmlNamespace );
            ValuationStatisticsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PriceValuation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
