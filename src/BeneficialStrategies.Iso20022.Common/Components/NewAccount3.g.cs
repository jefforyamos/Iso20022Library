﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NewAccount3.  ISO2002 ID# _a8noUdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the new account.
/// </summary>
public partial record NewAccount3
     : IIsoXmlSerilizable<NewAccount3>
{
    #nullable enable
    
    /// <summary>
    /// Details of the new account.
    /// </summary>
    public required CashAccount41 Account { get; init; } 
    /// <summary>
    /// Party or parties to be identified in the context of account operations.
    /// </summary>
    public IndividualPerson36? AccountParty { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _a99FE9cZEeqRFcf2R4bPBw
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    public Organisation35? Organisation { get; init; } 
    
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
        writer.WriteStartElement(null, "Acct", xmlNamespace );
        Account.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize AccountParty, multiplicity Unknown
        if (Organisation is Organisation35 OrganisationValue)
        {
            writer.WriteStartElement(null, "Org", xmlNamespace );
            OrganisationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static NewAccount3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
