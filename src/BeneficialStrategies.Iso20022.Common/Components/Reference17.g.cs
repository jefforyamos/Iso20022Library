﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference17.  ISO2002 ID# _QnOWE9p-Ed-ak6NoX_4Aeg_-1322304897.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
public partial record Reference17
     : IIsoXmlSerilizable<Reference17>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the collateral substitution request.
    /// </summary>
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    /// <summary>
    /// Identification of the collateral substitution response.
    /// </summary>
    public IsoMax35Text? CollateralSubstitutionResponseIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "CollSbstitnReqId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(CollateralSubstitutionRequestIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (CollateralSubstitutionResponseIdentification is IsoMax35Text CollateralSubstitutionResponseIdentificationValue)
        {
            writer.WriteStartElement(null, "CollSbstitnRspnId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CollateralSubstitutionResponseIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static Reference17 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
