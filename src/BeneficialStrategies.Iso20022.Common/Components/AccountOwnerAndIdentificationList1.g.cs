﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountOwnerAndIdentificationList1.  ISO2002 ID# _UHyvQCDvEeav65mEytrgaA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// List of account owner and identifiers.
/// </summary>
public partial record AccountOwnerAndIdentificationList1
     : IIsoXmlSerilizable<AccountOwnerAndIdentificationList1>
{
    #nullable enable
    
    /// <summary>
    /// List of the identifier pairs.
    /// </summary>
    public AccountOwnerAndIdentification1? List { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _qhLMECDvEeav65mEytrgaA
    
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
        // Not sure how to serialize List, multiplicity Unknown
    }
    public static AccountOwnerAndIdentificationList1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
