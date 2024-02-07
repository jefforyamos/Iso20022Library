﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AustralianSmallNetworkIdentification.  ISO2002 ID# _TDPFgdp-Ed-ak6NoX_4Aeg_1990860942.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice;

/// <summary>
/// Small network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
/// </summary>
public partial record AustralianSmallNetworkIdentification : ClearingSystemMemberIdentification2Choice_
     , IIsoXmlSerilizable<AustralianSmallNetworkIdentification>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// The small network list of the Australian Bank State Branch (BSB) Code. The codes are used for identifying Australian financial institutions, as assigned by the Australian Payments Clearing Association (APCA).
    /// </summary>
    public required IsoSmallNetworkIdentifier Value { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "AUBSBs", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoSmallNetworkIdentifier(Value)); // data type SmallNetworkIdentifier System.String
        writer.WriteEndElement();
    }
    public static new AustralianSmallNetworkIdentification Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
