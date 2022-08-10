namespace C_Sharp_Essential.Library;

public interface IMapper<S, T>
    {
    T Map(S source);
    }
