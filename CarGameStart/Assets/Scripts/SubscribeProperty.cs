using System;

public class SubscribeProperty<T> : IRedOnlySubscribeProperty<T>
{
    private T _value;
    private Action<T> _onChangevalue;

    public T Value 
    {
        get => _value;
        set
        {
            _value = value;
            _onChangevalue?.Invoke(value);

        }
    }

    public void SubscribeOnChange(Action<T> subscriptionAction)
    {
        _onChangevalue += subscriptionAction;
    }

    public void UnSubscribeOnChange(Action<T> unSubscriptionAction)
    {
        _onChangevalue -= unSubscriptionAction;
    }
}
