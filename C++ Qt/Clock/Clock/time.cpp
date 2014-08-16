#include "time.h"
#include <QTime>
#include <QtMath>

Time::Time()
{
}

Time::Time(int value)
{
    Time::relativelyGMT = value - 4;
}

QRectF Time::boundingRect() const
{
    return QRectF(0, 0, 300, 300);
}

QTime Time::knowTime()
{
    QTime *time = new QTime;
    QTime realTime = time->currentTime();
    delete time;
    return realTime;
}

QLineF Time::lineSecond()
{ 
    double realSecond = Time::knowTime().second();
    double realAngle = 3.14 * realSecond / 30;
    double alpha = - 3.14 / 2 + realAngle;
    double x = 130 * cos(alpha) - 0 * sin(alpha) + 150;
    double y = 130 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(150, 150, x, y);
}

QLineF Time::lineMinute()
{
    double realMinute = knowTime().minute();
    double realSecond = knowTime().second();
    double realAngle = 3.14 * (realMinute + realSecond / 60) / 30;
    double alpha = - 3.14 / 2 + realAngle;
    double x = 140 * cos(alpha) - 0 * sin(alpha) + 150;
    double y = 140 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(150, 150, x, y);
}

QLineF Time::lineHour()
{
    double realHour = knowTime().hour();
    double realMinute = knowTime().minute();
    double realSecond = knowTime().second();
    double realAngle = 3.14 * (realHour + Time::relativelyGMT + (realMinute + realSecond / 60) / 60) / 6;
    double alpha = - 3.14 / 2 + realAngle;
    double x = 110 * cos(alpha) - 0 * sin(alpha) + 150;
    double y = 110 * sin(alpha) + 0 * cos(alpha) + 150;
    return QLineF(150, 150, x, y);
}

void Time::paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget)
{
    painter->drawLine(lineSecond());
    painter->drawLine(lineMinute());
    painter->drawLine(lineHour());
}
