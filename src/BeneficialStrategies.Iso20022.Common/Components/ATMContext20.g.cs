﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMContext20.  ISO2002 ID# _CdeSga5EEeWCgYcWSNgX5g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context of the exception.
/// </summary>
public partial record ATMContext20
     : IIsoXmlSerilizable<ATMContext20>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the exception occurred.
    /// </summary>
    public IsoMax35Text? SessionReference { get; init; } 
    /// <summary>
    /// Service provided by the ATM inside the session.
    /// </summary>
    public required ATMService24 Service { get; init; } 
    
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
        if (SessionReference is IsoMax35Text SessionReferenceValue)
        {
            writer.WriteStartElement(null, "SsnRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(SessionReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Svc", xmlNamespace );
        Service.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static ATMContext20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
