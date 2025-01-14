using TouchPortalSDK.Interfaces;
using TouchPortalSDK.Messages.Models;

namespace TouchPortalSDK.Messages.Events
{
    /// <summary>
    /// This event is fired when a user selects an item from an action's choice list.
    /// This is especially useful when your action (or event/connector) has multiple drop down list boxes where selecting an item in the first needs to repopulate the second.
    /// </summary>
    public class ListChangeEvent : ITouchPortalMessage
    {
        /// <summary>
        /// When setting up an action in the Touch Portal UI. This event is fired if the user selects and item in the dropdown for a choice list.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The id of the plugin.
        /// </summary>
        public string PluginId { get; set; }

        /// <summary>
        /// The actionId the list (dropdown) is a part of.
        /// </summary>
        public string ActionId { get; set; }

        /// <summary>
        /// The dataId the list (dropdown) is built upon.
        /// </summary>
        public string ListId { get; set; }

        /// <summary>
        /// InstanceId is a unique name that identified the action the user is changing.
        /// A button might have multiple actions, and a action might be bound to multiple buttons.
        /// This id will be different. However, it can also be null.
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Value of the selected list (dropdown).
        /// Might be null if nothing is selected, ex. choices updated to something else.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Values is an {id, value} pairs dictionary of other options the user has selected for this action, not including the value of the instance being changed.
        /// Available since TP API v7. It may be `null` for TP v3.x (TP API &lt; v7)
        /// </summary>
        public ActionData Values { get; set; } = null;


        /// <inheritdoc cref="ITouchPortalMessage" />
        public Identifier GetIdentifier()
            => new Identifier(Type, ListId, InstanceId);
    }
}
