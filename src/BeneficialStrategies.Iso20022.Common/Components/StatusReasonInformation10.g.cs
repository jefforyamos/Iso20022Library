﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatusReasonInformation10.  ISO2002 ID# _kpLGou5NEeCisYr99QEiWA_743644615.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the status reason of the instruction.
/// </summary>
public partial record StatusReasonInformation10
     : IIsoXmlSerilizable<StatusReasonInformation10>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    public required StatusReason6Choice_ Reason { get; init; } 
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    public IsoMax140Text? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Rsn", xmlNamespace );
        Reason.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AdditionalInformation is IsoMax140Text AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AdditionalInformationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static StatusReasonInformation10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
