﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountAndParties1.  ISO2002 ID# _06D5001FEeGAs6v-iSb2RQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the account as the search criteria for the financial institution to do the investigation.
/// </summary>
public partial record AccountAndParties1
     : IIsoXmlSerilizable<AccountAndParties1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the account for the investigation.
    /// </summary>
    public required CashAccount25 Identification { get; init; } 
    /// <summary>
    /// Specifies the investigated parties related to the account such as the owner, beneficiary, signatory or any party playing a role in that account for which the investigation needs to be done.
    /// </summary>
    public required InvestigatedParties1Choice_ InvestigatedParties { get; init; } 
    /// <summary>
    /// Identifies the authority request type as a code.
    /// </summary>
    public AuthorityRequestType1? AuthorityRequestType { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _EcwSUUyvEeGcV5yVhSZuNw
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InvstgtdPties", xmlNamespace );
        InvestigatedParties.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize AuthorityRequestType, multiplicity Unknown
    }
    public static AccountAndParties1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
