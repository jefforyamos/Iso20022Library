﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerRecord4.  ISO2002 ID# _JF13dzB6EeqkRN6jaX_Nzg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the agent specific tracking system information of a payment transaction.
/// </summary>
public partial record TrackerRecord4
     : IIsoXmlSerilizable<TrackerRecord4>
{
    #nullable enable
    
    /// <summary>
    /// Identification of an agent in the tracker.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? Agent { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ChargesAmount { get; init; } 
    /// <summary>
    /// Provides details of the rate and the currencies used in the foreign exchange.
    /// </summary>
    public CurrencyExchange13? ExchangeRateData { get; init; } 
    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    public IsoISODateTime? ProcessingDateTime { get; init; } 
    
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
        if (Agent is BranchAndFinancialInstitutionIdentification6 AgentValue)
        {
            writer.WriteStartElement(null, "Agt", xmlNamespace );
            AgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ChargeBearer is ChargeBearerType1Code ChargeBearerValue)
        {
            writer.WriteStartElement(null, "ChrgBr", xmlNamespace );
            writer.WriteValue(ChargeBearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargesAmount is IsoActiveCurrencyAndAmount ChargesAmountValue)
        {
            writer.WriteStartElement(null, "ChrgsAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(ChargesAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (ExchangeRateData is CurrencyExchange13 ExchangeRateDataValue)
        {
            writer.WriteStartElement(null, "XchgRateData", xmlNamespace );
            ExchangeRateDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProcessingDateTime is IsoISODateTime ProcessingDateTimeValue)
        {
            writer.WriteStartElement(null, "PrcgDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(ProcessingDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
    }
    public static TrackerRecord4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
