﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralDate2.  ISO2002 ID# _qxz5MRInEeyZaPkaPAzTvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Dates related to the triparty collateral instruction or transactions.
/// </summary>
public partial record CollateralDate2
     : IIsoXmlSerilizable<CollateralDate2>
{
    #nullable enable
    
    /// <summary>
    /// Date the transaction was agreed between the trading parties.
    /// </summary>
    public IsoISODate? TradeDate { get; init; } 
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date on which the financial instruments are to be delivered or received.
    /// </summary>
    public IsoISODate? SettlementDate { get; init; } 
    
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
        if (TradeDate is IsoISODate TradeDateValue)
        {
            writer.WriteStartElement(null, "TradDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(TradeDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (RequestedExecutionDate is DateAndDateTime2Choice_ RequestedExecutionDateValue)
        {
            writer.WriteStartElement(null, "ReqdExctnDt", xmlNamespace );
            RequestedExecutionDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementDate is IsoISODate SettlementDateValue)
        {
            writer.WriteStartElement(null, "SttlmDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(SettlementDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static CollateralDate2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
