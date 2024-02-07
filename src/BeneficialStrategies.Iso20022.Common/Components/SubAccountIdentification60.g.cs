﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubAccountIdentification60.  ISO2002 ID# _f4nWkemrEemUgrefIx730g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides all sub-account details.
/// </summary>
public partial record SubAccountIdentification60
     : IIsoXmlSerilizable<SubAccountIdentification60>
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification144? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount25 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Indicates whether there is activity or information update reported in the statement.
    /// </summary>
    public required IsoYesNoIndicator ActivityIndicator { get; init; } 
    /// <summary>
    /// Reporting per financial instrument.
    /// </summary>
    public FinancialInstrumentDetails35? FinancialInstrumentDetails { get; init; } 
    
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
        if (AccountOwner is PartyIdentification144 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ActvtyInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ActivityIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (FinancialInstrumentDetails is FinancialInstrumentDetails35 FinancialInstrumentDetailsValue)
        {
            writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
            FinancialInstrumentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubAccountIdentification60 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
