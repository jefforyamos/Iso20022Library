﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralValueReport3.  ISO2002 ID# _-DiXdTpvEemk2e6qGBk8IQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the collateral value report or on a business error.
/// </summary>
public partial record CollateralValueReport3
     : IIsoXmlSerilizable<CollateralValueReport3>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the account on which information is requested.
    /// </summary>
    public required CashAccount38 CashAccount { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public SystemPartyIdentification11? CashAccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the securities account owner.
    /// </summary>
    public SystemPartyIdentification8? SecuritiesAccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the securities account on behalf of the account owner.
    /// </summary>
    public PartyIdentification136? SecuritiesAccountServicer { get; init; } 
    /// <summary>
    /// Provides information specific to the report on collateral value positions.
    /// </summary>
    public CollateralValueReportOrError6Choice_? CollateralValueReport { get; init; } 
    
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
        writer.WriteStartElement(null, "CshAcct", xmlNamespace );
        CashAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashAccountOwner is SystemPartyIdentification11 CashAccountOwnerValue)
        {
            writer.WriteStartElement(null, "CshAcctOwnr", xmlNamespace );
            CashAccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAccountServicer is BranchAndFinancialInstitutionIdentification6 CashAccountServicerValue)
        {
            writer.WriteStartElement(null, "CshAcctSvcr", xmlNamespace );
            CashAccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesAccountOwner is SystemPartyIdentification8 SecuritiesAccountOwnerValue)
        {
            writer.WriteStartElement(null, "SctiesAcctOwnr", xmlNamespace );
            SecuritiesAccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesAccountServicer is PartyIdentification136 SecuritiesAccountServicerValue)
        {
            writer.WriteStartElement(null, "SctiesAcctSvcr", xmlNamespace );
            SecuritiesAccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralValueReport is CollateralValueReportOrError6Choice_ CollateralValueReportValue)
        {
            writer.WriteStartElement(null, "CollValRpt", xmlNamespace );
            CollateralValueReportValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralValueReport3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
