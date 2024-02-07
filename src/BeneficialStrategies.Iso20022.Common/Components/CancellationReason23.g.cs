﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CancellationReason23.  ISO2002 ID# _khfKEewOEeiazoAmcoGsBQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request is cancelled.
/// </summary>
public partial record CancellationReason23
     : IIsoXmlSerilizable<CancellationReason23>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    public required CancellationReason36Choice_ Code { get; init; } 
    /// <summary>
    /// Provides the corporate action event identification of the event that triggered the cancellation.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "Cd", xmlNamespace );
        Code.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CorporateActionEventIdentification is IsoMax35Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionEventIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static CancellationReason23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
