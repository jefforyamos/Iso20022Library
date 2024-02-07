﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateAmendment2.  ISO2002 ID# _tlOvAVkyEeGeoaLUQk__nA_-1635096845.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the mandate to be amended and gives details of the new mandate.
/// </summary>
public partial record MandateAmendment2
     : IIsoXmlSerilizable<MandateAmendment2>
{
    #nullable enable
    
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalMessageInformation1? OriginalMessageInformation { get; init; } 
    /// <summary>
    /// Provides detailed information on the amendment reason.
    /// </summary>
    public required MandateAmendmentReason1 AmendmentReason { get; init; } 
    /// <summary>
    /// Provides the amended mandate data.
    /// </summary>
    public required Mandate3 Mandate { get; init; } 
    /// <summary>
    /// Provides the original mandate data.
    /// </summary>
    public required OriginalMandate2Choice_ OriginalMandate { get; init; } 
    
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
        if (OriginalMessageInformation is OriginalMessageInformation1 OriginalMessageInformationValue)
        {
            writer.WriteStartElement(null, "OrgnlMsgInf", xmlNamespace );
            OriginalMessageInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AmdmntRsn", xmlNamespace );
        AmendmentReason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Mndt", xmlNamespace );
        Mandate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OrgnlMndt", xmlNamespace );
        OriginalMandate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static MandateAmendment2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
