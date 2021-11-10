using System;

public interface IRedOnlySubscribeProperty<T>
{
   T Value { get; }

    void SubscribeOnChange(Action<T> subscriptionAction);
    void UnSubscribeOnChange(Action<T> unSubscriptionAction);

}
