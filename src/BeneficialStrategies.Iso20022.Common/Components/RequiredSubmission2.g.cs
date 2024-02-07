﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequiredSubmission2.  ISO2002 ID# _Rax58Np-Ed-ak6NoX_4Aeg_1462344534.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details relative to the submission of a data set.
/// </summary>
public partial record RequiredSubmission2
     : IIsoXmlSerilizable<RequiredSubmission2>
{
    #nullable enable
    
    /// <summary>
    /// Specifies with party(ies) is authorised to submit the data set as part of the transaction.
    /// </summary>
    public BICIdentification1? Submitter { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Rax58dp-Ed-ak6NoX_4Aeg_1833600823
    
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
        // Not sure how to serialize Submitter, multiplicity Unknown
    }
    public static RequiredSubmission2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
