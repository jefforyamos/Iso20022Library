﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Consignment2.  ISO2002 ID# _S-10hgEcEeCQm6a_G2yO_w_-323080810.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the arrangement of the transport of goods and services and the parties involved in this process.
/// </summary>
public partial record Consignment2
     : IIsoXmlSerilizable<Consignment2>
{
    #nullable enable
    
    /// <summary>
    /// Party consigning goods as stipulated in the transport contract by the party ordering transport.
    /// </summary>
    public TradeParty1? Consignor { get; init; } 
    /// <summary>
    /// Party to which goods are consigned.
    /// </summary>
    public TradeParty1? Consignee { get; init; } 
    /// <summary>
    /// Particular aircraft, vehicle, vessel or other device used for the transport of a consignment.
    /// </summary>
    public TransportMeans3? TransportMeans { get; init; } 
    
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
        if (Consignor is TradeParty1 ConsignorValue)
        {
            writer.WriteStartElement(null, "Consgnr", xmlNamespace );
            ConsignorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Consignee is TradeParty1 ConsigneeValue)
        {
            writer.WriteStartElement(null, "Consgn", xmlNamespace );
            ConsigneeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransportMeans is TransportMeans3 TransportMeansValue)
        {
            writer.WriteStartElement(null, "TrnsprtMeans", xmlNamespace );
            TransportMeansValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Consignment2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
