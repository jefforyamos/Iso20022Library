﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DebtorActivationStatusReason2.  ISO2002 ID# _P4LStOIKEeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status reason of the debtor activation request.
/// </summary>
public partial record DebtorActivationStatusReason2
     : IIsoXmlSerilizable<DebtorActivationStatusReason2>
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    public RTPPartyIdentification1? Originator { get; init; } 
    /// <summary>
    /// Specifies the status reason for the debtor activation request.
    /// </summary>
    public required DebtorActivationStatusReason1Choice_ Reason { get; init; } 
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
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
        if (Originator is RTPPartyIdentification1 OriginatorValue)
        {
            writer.WriteStartElement(null, "Orgtr", xmlNamespace );
            OriginatorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        Reason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax105Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax105Text(AdditionalInformationValue)); // data type Max105Text System.String
            writer.WriteEndElement();
        }
    }
    public static DebtorActivationStatusReason2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
