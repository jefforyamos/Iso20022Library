﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReferredDocumentType4.  ISO2002 ID# _Xf7GCR77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the document referred in the remittance information.
/// </summary>
public partial record ReferredDocumentType4
     : IIsoXmlSerilizable<ReferredDocumentType4>
{
    #nullable enable
    
    /// <summary>
    /// Provides the type details of the referred document.
    /// </summary>
    public required ReferredDocumentType3Choice_ CodeOrProprietary { get; init; } 
    /// <summary>
    /// Identification of the issuer of the reference document type.
    /// </summary>
    public IsoMax35Text? Issuer { get; init; } 
    
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
        writer.WriteStartElement(null, "CdOrPrtry", xmlNamespace );
        CodeOrProprietary.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Issuer is IsoMax35Text IssuerValue)
        {
            writer.WriteStartElement(null, "Issr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(IssuerValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static ReferredDocumentType4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
