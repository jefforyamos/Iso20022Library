﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReceivingPartiesAndAccount16.  ISO2002 ID# _1gjt9TbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record ReceivingPartiesAndAccount16
     : IIsoXmlSerilizable<ReceivingPartiesAndAccount16>
{
    #nullable enable
    
    /// <summary>
    /// Party that acts on behalf of the buyer of securities when the buyer does not have a direct relationship with the receiving agent.
    /// </summary>
    public PartyIdentificationAndAccount147? ReceiversCustodianDetails { get; init; } 
    /// <summary>
    /// Party that the receiver's custodian uses to effect the receipt of a security, when the receiver's custodian does not have a direct relationship with the receiving agent.
    /// </summary>
    public PartyIdentificationAndAccount147? ReceiversIntermediary1Details { get; init; } 
    /// <summary>
    /// Party that interacts with the receiver’s intermediary 1.
    /// </summary>
    public PartyIdentificationAndAccount147? ReceiversIntermediary2Details { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent at the place of settlement, for example, central securities depository.
    /// </summary>
    public required PartyIdentificationAndAccount147 ReceivingAgentDetails { get; init; } 
    
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
        if (ReceiversCustodianDetails is PartyIdentificationAndAccount147 ReceiversCustodianDetailsValue)
        {
            writer.WriteStartElement(null, "RcvrsCtdnDtls", xmlNamespace );
            ReceiversCustodianDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceiversIntermediary1Details is PartyIdentificationAndAccount147 ReceiversIntermediary1DetailsValue)
        {
            writer.WriteStartElement(null, "RcvrsIntrmy1Dtls", xmlNamespace );
            ReceiversIntermediary1DetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReceiversIntermediary2Details is PartyIdentificationAndAccount147 ReceiversIntermediary2DetailsValue)
        {
            writer.WriteStartElement(null, "RcvrsIntrmy2Dtls", xmlNamespace );
            ReceiversIntermediary2DetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RcvgAgtDtls", xmlNamespace );
        ReceivingAgentDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ReceivingPartiesAndAccount16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
