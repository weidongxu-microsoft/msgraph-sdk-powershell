namespace Sample.API
{
    using static Sample.API.Runtime.Extensions;
    /// <summary>
    /// Low-level API implementation for the Partial Graph API service.
    /// </summary>
    public partial class PartialGraphAPI
    {

        /// <summary>Get me</summary>
        /// <param name="Select">Select properties to be returned</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Sample.API.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task MeUserGetUser(string[] Select, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IMicrosoftGraphUser>, global::System.Threading.Tasks.Task> onOK, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IOdataError>, global::System.Threading.Tasks.Task> onDefault, Sample.API.Runtime.IEventListener eventListener, Sample.API.Runtime.ISendAsync sender)
        {
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL

                string url = "https://graph.microsoft.com/v1.0/me";

                if (Select != null && Select.Length > 0)
                {
                    url = url + "?" + Select[0];
                    for (int i = 1; i < Select.Length; i++)
                    {
                        url = url + "," + Select[i];
                    }
                }

                var _url = new global::System.Uri(url);

                //Commenting the generated code below, as it results in invalid URI
                /*
                var _url = new global::System.Uri((
                        "https://graph.microsoft.com/v1.0/me"
                        + "?"
                        + Select != null && Select.Length > 0 ? "Select=" + System.Uri.EscapeDataString(System.Linq.Enumerable.Aggregate(Select, (current, each) => current + "," + (string.IsNullOrEmpty(each) ? System.Uri.EscapeDataString(each) : System.String.Empty))) : System.String.Empty
                        ).TrimEnd('?','&'));
                */

                await eventListener.Signal(Sample.API.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new global::System.Net.Http.HttpRequestMessage(Sample.API.Runtime.Method.Get, _url);
                await eventListener.Signal(Sample.API.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Sample.API.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.MeUserGetUser_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="MeUserGetUser" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Sample.API.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task MeUserGetUser_Call(global::System.Net.Http.HttpRequestMessage request, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IMicrosoftGraphUser>, global::System.Threading.Tasks.Task> onOK, global::System.Func<global::System.Net.Http.HttpResponseMessage, global::System.Threading.Tasks.Task<Sample.API.Models.IOdataError>, global::System.Threading.Tasks.Task> onDefault, Sample.API.Runtime.IEventListener eventListener, Sample.API.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                global::System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Sample.API.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Sample.API.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case global::System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Sample.API.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Sample.API.Models.MicrosoftGraphUser.FromJson(Sample.API.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Sample.API.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Sample.API.Models.OdataError.FromJson(Sample.API.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Sample.API.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="MeUserGetUser" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="Select">Select properties to be returned</param>
        /// <param name="eventListener">an <see cref="Sample.API.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="global::System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async global::System.Threading.Tasks.Task MeUserGetUser_Validate(string[] Select, Sample.API.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                if (Select != null ) {
                        for (int __i = 0; __i < Select.Length; __i++) {
                          await eventListener.AssertEnum($"Select[{__i}]",Select[__i],@"id", @"deletedDateTime", @"accountEnabled", @"ageGroup", @"assignedLicenses", @"assignedPlans", @"businessPhones", @"city", @"companyName", @"consentProvidedForMinor", @"country", @"department", @"displayName", @"givenName", @"imAddresses", @"jobTitle", @"legalAgeGroupClassification", @"mail", @"mailNickname", @"mobilePhone", @"onPremisesExtensionAttributes", @"onPremisesImmutableId", @"onPremisesLastSyncDateTime", @"onPremisesProvisioningErrors", @"onPremisesSecurityIdentifier", @"onPremisesSyncEnabled", @"onPremisesDomainName", @"onPremisesSamAccountName", @"onPremisesUserPrincipalName", @"passwordPolicies", @"passwordProfile", @"officeLocation", @"postalCode", @"preferredLanguage", @"provisionedPlans", @"proxyAddresses", @"state", @"streetAddress", @"surname", @"usageLocation", @"userPrincipalName", @"userType", @"mailboxSettings", @"aboutMe", @"birthday", @"hireDate", @"interests", @"mySite", @"pastProjects", @"preferredName", @"responsibilities", @"schools", @"skills", @"deviceEnrollmentLimit", @"ownedDevices", @"registeredDevices", @"manager", @"directReports", @"memberOf", @"createdObjects", @"ownedObjects", @"licenseDetails", @"extensions", @"outlook", @"messages", @"mailFolders", @"calendar", @"calendars", @"calendarGroups", @"calendarView", @"events", @"people", @"contacts", @"contactFolders", @"inferenceClassification", @"photo", @"photos", @"drive", @"drives", @"planner", @"onenote", @"managedDevices", @"managedAppRegistrations", @"deviceManagementTroubleshootingEvents", @"activities", @"insights", @"settings");
                        }
                      }
            }
        }
    }
}