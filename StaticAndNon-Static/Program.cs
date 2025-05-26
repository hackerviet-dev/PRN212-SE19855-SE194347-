static int sum(int a, int b)
{
    return a + b;
}
void callsum()
{
    int s = sum(5, 8); //ok
}
double average(int a, int b)
{
    return (a + b) / 2.0;
}
static void callaverage()
{
    double s = average(5, 6); //not ok tai vi double average tao truoc ham static
}
