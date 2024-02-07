﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GeneralBusinessReport6.  ISO2002 ID# _QdJoBXhdEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the business information or on a business error.
/// </summary>
public partial record GeneralBusinessReport6
     : IIsoXmlSerilizable<GeneralBusinessReport6>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
    /// </summary>
    public required IsoMax35Text BusinessInformationReference { get; init; } 
    /// <summary>
    /// Requested business information.
    /// </summary>
    public required GeneralBusinessOrError8Choice_ GeneralBusinessOrError { get; init; } 
    
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
        writer.WriteStartElement(null, "BizInfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(BusinessInformationReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "GnlBizOrErr", xmlNamespace );
        GeneralBusinessOrError.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static GeneralBusinessReport6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
