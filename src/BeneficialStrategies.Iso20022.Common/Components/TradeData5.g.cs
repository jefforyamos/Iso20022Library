﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradeData5.  ISO2002 ID# _SvM2BAEcEeCQm6a_G2yO_w_-47074384.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status of a trade.
/// </summary>
public partial record TradeData5
     : IIsoXmlSerilizable<TradeData5>
{
    #nullable enable
    
    /// <summary>
    /// Reference to the unique system identification assigned to the trade by the central matching system.
    /// </summary>
    public required IsoMax35Text MatchingSystemUniqueReference { get; init; } 
    /// <summary>
    /// Reference to the identification of the notification for which the status is given, as assigned by the participant that submitted the foreign exchange trade.
    /// </summary>
    public IsoMax35Text? NotificationIdentification { get; init; } 
    /// <summary>
    /// Reference to the unique matching identification assigned to the trade and to the matching trade from the counterparty by the central matching system.
    /// </summary>
    public IsoMax35Text? MatchingSystemMatchingReference { get; init; } 
    /// <summary>
    /// Specifies the date and time at which the current status was assigned to the individual trade.
    /// </summary>
    public IsoISODateTime? CurrentStatusDateTime { get; init; } 
    /// <summary>
    /// Product type of the individual trade.
    /// </summary>
    public IsoMax35Text? ProductType { get; init; } 
    
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
        writer.WriteStartElement(null, "MtchgSysUnqRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(MatchingSystemUniqueReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (NotificationIdentification is IsoMax35Text NotificationIdentificationValue)
        {
            writer.WriteStartElement(null, "NtfctnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(NotificationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MatchingSystemMatchingReference is IsoMax35Text MatchingSystemMatchingReferenceValue)
        {
            writer.WriteStartElement(null, "MtchgSysMtchgRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MatchingSystemMatchingReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CurrentStatusDateTime is IsoISODateTime CurrentStatusDateTimeValue)
        {
            writer.WriteStartElement(null, "CurStsDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(CurrentStatusDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        if (ProductType is IsoMax35Text ProductTypeValue)
        {
            writer.WriteStartElement(null, "PdctTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProductTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static TradeData5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
