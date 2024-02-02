﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DocumentLineInformation1.  ISO2002 ID# _Cy5dt6JpEeKmspP9k_hIRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides document line information.
/// </summary>
[DataContract]
[XmlType]
public partial record DocumentLineInformation1
{
    #nullable enable
    
    /// <summary>
    /// Provides identification of the document line.
    /// </summary>
    [DataMember]
    public ValueList<DocumentLineIdentification1> Identification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Description associated with the document line.
    /// </summary>
    [DataMember]
    public IsoMax2048Text? Description { get; init; } 
    /// <summary>
    /// Provides details on the amounts of the document line.
    /// </summary>
    [DataMember]
    public RemittanceAmount3? Amount { get; init; } 
    
    #nullable disable
}
