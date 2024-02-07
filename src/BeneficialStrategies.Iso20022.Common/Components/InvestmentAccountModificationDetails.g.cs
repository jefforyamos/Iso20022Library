﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountModificationDetails.  ISO2002 ID# _REb2gdp-Ed-ak6NoX_4Aeg_691417052.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information about the reason for the modification and about the application request which triggered this modification.
/// </summary>
public partial record InvestmentAccountModificationDetails
     : IIsoXmlSerilizable<InvestmentAccountModificationDetails>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the modification brought to the investment account information.
    /// </summary>
    public IsoMax350Text? ModificationReason { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
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
        if (ModificationReason is IsoMax350Text ModificationReasonValue)
        {
            writer.WriteStartElement(null, "ModRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(ModificationReasonValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (AccountApplicationIdentification is IsoMax35Text AccountApplicationIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctApplId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountApplicationIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static InvestmentAccountModificationDetails Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
